/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    var getDirection=function()
    {
        var checked=$("input:[type=radio]:checked")[0].id;
        return null;
    };
    var initMenu=function()
    {
        $("#menu").kendoMenu({direction:getDirection()}).css({marginRight:"220px"});
    };
    var original=$("#menu").clone(true);
    original.find(".k-state-active").removeClass("k-state-active");
    $("#apply").click(function(e)
    {
        e.preventDefault();
        var menu=$("#menu"),clone=original.clone(true);
        menu.data("kendoMenu").close($("#menu .k-link"));
        menu.replaceWith(clone);
        initMenu();
    });
    initMenu();
};