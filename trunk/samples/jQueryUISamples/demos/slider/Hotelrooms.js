/*Generated by SharpKit 5 v5.00.0000*/
$(OnReady);
function OnReady()
{
    var select = $("#minbeds");
    var slider = $("<div id=\'slider\'></div>").insertAfter(select).slider(
    {
        min: 1,
        max: 6,
        range: "min",
        value: select[0].selectedIndex + 1,
        slide: function (e, ui)
        {
            select[0].selectedIndex = ui.value - 1;
        }
    });
    $("#minbeds").change(function (e)
    {
        slider.slider("value", e.currentTarget.selectedIndex + 1);
    });
};