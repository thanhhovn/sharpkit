/*Generated by SharpKit 5 v4.29.7000*/
$(OnReady);
function OnReady()
{
    $("#datepicker").datepicker();
    $("#anim").change(function(e)
    {
        $("#datepicker").datepicker("option","showAnim",$(e.currentTarget).val());
    });
};
