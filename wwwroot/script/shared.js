function getDescription(id)
{
    var selector = document.querySelector(id);
    var dataAttribute = selector.getAttribute("data-description");

    return alert(dataAttribute);
}