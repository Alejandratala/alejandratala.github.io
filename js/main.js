window.onload = showPage(getPage(location))
// This function is checking for the page url. We added this so it would be able 
// to do the hidden ShowPage, and still load.
function getPage(url)
{
    let searchParams = new URLSearchParams(url.search);
    return searchParams.get('page');
}
// showPage, is meant to hide the pages that you are currently not on, so 
// if you click on Home, only home shows, and the rest should be hidden.
function showPage(page)
{
    document.getElementById('home').hidden=true;
    document.getElementById('about').hidden=true;
    document.getElementById('login').hidden=true;

    document.getElementById(page).hidden=false;
}