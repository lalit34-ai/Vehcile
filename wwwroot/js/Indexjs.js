// $(document).ready(function () {
//     $("input#submit").click(function () {
//         $.ajax({
//             type: "POST",
//             url: "mail.php", //process to mail
//             data: $('form.contact').serialize(),
//             success: function (msg) {
//                 $("#thanks").html(msg); //hide button and show thank you
//                 $("#form-content").modal('hide'); //hide popup  
//             },
//             error: function () {
//                 alert("failure");
//             }
//         });
//     });
//  });



      $(document).ready(function () {
            $("#submit").click(function () {
                var email = $("#emailInput").val();
                if (email !== "") {
                    $.ajax({
                        type: "POST",
                        url: "/Home/SubscribeToNewsletter",
                        data: { email: email },
                        success: function (response) {
                            alert("Thank you for subscribing to our newsletter.");
                            $("#emailInput").val(""); // Clear the input field after successful submission
                        },
                        error: function () {
                            alert("Failed to subscribe to the newsletter. Please try again later.");
                        }
                    });
                } else {
                    alert("Please enter a valid email address.");
                }
            });
        });