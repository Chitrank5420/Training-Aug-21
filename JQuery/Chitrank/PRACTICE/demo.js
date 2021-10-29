$(document).ready(function(){
    $("button").click(function(){
      $(".test").hide();
    });
  });

$(document).ready(function(){
    $("p").dblclick(function(){
        $(this).hide();
    })
})

$(document).ready(function(){
    $("#p1").mouseenter(function(){
        alert("You entered");
    })
})