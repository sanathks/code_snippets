function clr(el){
   $(':input',el)
       .not(':button, :submit, :reset, :hidden')
       .val('')
       .removeAttr('checked')
       .removeAttr('selected')
       .removeAttr("disabled");
   $(':select',el).val("0");
}