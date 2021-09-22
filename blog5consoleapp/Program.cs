using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace blog5consoleapp
{
    class Program
    {
        private DocumentClient client;

        static void Main(string[] args)
        {
            try
            {
                Program p = new Program();
                p.BasicOperations().Wait();
            }
            catch (DocumentClientException de)
            {
                Exception baseException = de.GetBaseException();
                Console.WriteLine("{0} error occurred: {1}, Message: {2}", de.StatusCode, de.Message, baseException.Message);
            }
            catch (Exception e)
            {
                Exception baseException = e.GetBaseException();
                Console.WriteLine("Error: {0}, Message: {1}", e.Message, baseException.Message);
            }
            finally
            {
                Console.WriteLine("End of demo, press any key to exit.");
                Console.ReadKey();
            }
        }

        private async Task BasicOperations()
        {
            this.client = new DocumentClient(new Uri(ConfigurationManager.AppSettings["accountEndpoint"]), ConfigurationManager.AppSettings["accountKey"]);

            await this.client.CreateDatabaseIfNotExistsAsync(new Database { Id = "Blog5Database" });

            await this.client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri("Blog5Database"), new DocumentCollection { Id = "User" });

            Console.WriteLine("Database and collection validation complete");

            User a = new User
            {
                Id = "1",
                LastName = "Talamantes",
                FirstName = "Alejandra"
            };

            await this.CreateUserDocumentIfNotExists("Blog5Database", "User", a);

            User b = new User
            {
                Id = "2",
                LastName = "Koch",
                FirstName = "Bernd"
            };

            await this.CreateUserDocumentIfNotExists("Blog5Database", "User", b);
            await this.ReadUserDocument("Blog5Database","User", a);

        }

        // probs dont need this.
        private void WriteToConsoleAndPromptToContinue(string format, params object[] args)
        {
            Console.WriteLine(format, args);
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private async Task ReadUserDocument(string databaseName, string collectionName, User user)
        {
            try
            {
                await this.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, user.Id), new RequestOptions { PartitionKey = new PartitionKey(user.Id) });
                this.WriteToConsoleAndPromptToContinue("Read user {0}", user.Id);
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    this.WriteToConsoleAndPromptToContinue("User {0} not read", user.Id);
                }
                else
                {
                    throw;
                }
            }
        }

        private async Task CreateUserDocumentIfNotExists(string databaseName, string collectionName, User user)
        {
            try
            {
                await this.client.ReadDocumentAsync(UriFactory.CreateDocumentUri(databaseName, collectionName, user.Id), new RequestOptions { PartitionKey = new PartitionKey(user.Id) });
                this.WriteToConsoleAndPromptToContinue("User {0} already exists in the database", user.Id);
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    await this.client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(databaseName, collectionName), user);
                    this.WriteToConsoleAndPromptToContinue("Created User {0}", user.Id);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
