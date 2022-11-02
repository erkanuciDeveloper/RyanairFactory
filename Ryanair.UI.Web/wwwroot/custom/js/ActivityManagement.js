$(document).ready(function () {
    var result = true;
    $("#btnActivityRegister").click(function () {
        result = true;
        var IdActivityName = $('#IdActivityName').val();
        var IdActivityType = $('#IdActivityType').val();
        var IdActivityStarTime = $('#IdActivityStarTime').val();
        var IdActivityEndTime = $('#IdActivityEndTime').val();
        var IdActivityWorkers = $('#IdActivityWorkers').val();
        var IdActivityDetails = $('#IdActivityDetails').val();
        var workercount = IdActivityWorkers;
        if (IdActivityName == "") {
            swal.fire({
                title: "Activity Create",
                text: "ActivityName",
                icon: "warning",
                confirmButtonClass: "btn-warning",
                showCancelButton: false,
                confirmButtonText: "Tamam",
                closeOnConfirm: "true",
                timer: 15500
            });
            document.getElementById("IdActivityName").className = "formscon";

            result = false;
        }
        else if (IdActivityType == "") {
            swal.fire({
                title: "Activity Create",
                text: "LIdActivityType",
                icon: "warning",
                confirmButtonClass: "btn-warning",
                showCancelButton: false,
                confirmButtonText: "Tamam",
                closeOnConfirm: "true",
                timer: 15500
            });
            document.getElementById("IdActivityType").className = "formscon";
            result = false;
        }
        else if (IdActivityStarTime == "") {
            swal.fire({
                title: "Activity Create",
                text: "IdActivityStarTime",
                icon: "warning",
                confirmButtonClass: "btn-warning",
                showCancelButton: false,
                confirmButtonText: "Tamam",
                closeOnConfirm: "true",
                timer: 15500
            });
            document.getElementById("IdActivityStarTime").className = "formscon";
            result = false;
        }
        else if (IdActivityEndTime == "") {
            swal.fire({
                title: "Activity Create",
                text: "IdActivityEndTime",
                icon: "warning",
                confirmButtonClass: "btn-warning",
                showCancelButton: false,
                confirmButtonText: "Tamam",
                closeOnConfirm: "true",
                timer: 15500
            });
            document.getElementById("IdActivityEndTime").className = "formscon";
            result = false;
        }
        else if (IdActivityWorkers == "") {
            swal.fire({
                title: "Activity Create",
                text: "IdActivityWorkers",
                icon: "warning",
                confirmButtonClass: "btn-warning",
                showCancelButton: false,
                confirmButtonText: "Tamam",
                closeOnConfirm: "true",
                timer: 15500
            });
            document.getElementById("IdActivityWorkers").className = "formsconmultutext";
            result = false;
        }
        else if (IdActivityDetails == "") {

            swal.fire({
                title: "Activity Create",
                text: "IdActivityDetails",
                icon: "warning",
                confirmButtonClass: "btn-warning",
                showCancelButton: false,
                confirmButtonText: "Tamam",
                closeOnConfirm: "true",
                timer: 15500
            });
            document.getElementById("IdActivityDetails").className = "formsconmultutext";
            result = false;
        }
        else {
            if (IdActivityType == "1" && workercount.length > 1) {
                swal.fire({
                    title: "Activity Create",
                    text: "Only one worker can do this job",
                    icon: "error",
                    confirmButtonClass: "btn-danger",
                });
                result = false;
            }
            else {
                if (result) {
                    var collectedData = CollectInfo();
                    var info = JSON.stringify(collectedData);
                    $.ajax({
                        type: "POST",
                        url: "/ActivitiesManagement/ActivitiesRegister",
                        contentType: "application/json; charset=utf-8",
                        data: info,
                        dataType: "json",
                        success: function (response) {
                            if (!response.isSuccess) {
                                swal.fire({
                                    title: "Activity Create",
                                    text: response.message,
                                    icon: "error",
                                    confirmButtonClass: "btn-danger",
                                });
                            }
                            else {
                                swal.fire({
                                    title: "Activity Create",
                                    text: "Activity created..",
                                    icon: "success",
                                    confirmButtonClass: "btn-success",
                                    timer: 15000
                                });
                                setTimeout(function () {
                                    window.location = '/Factory/Index';
                                }, 5000)
                             
                          


                                $('#IdActivityName').val('');
                                $('#IdActivityType').val('');
                                $('#IdActivityStarTime').val('');
                                $('#IdActivityEndTime').val('');
                                $('#IdActivityWorkers').val('');
                                $('#IdActivityDetails').val('');


                            }
                        },
                        error: function (xhr, textStatus, errorThrown) {

                            //var collectedData = GetErrorMessage(xhr.status);
                            ////var info = JSON.stringify(collectedData);			
                            //swal.fire({
                            //	title: "Üye Ol",
                            //	text: collectedData,
                            //	icon: "error",
                            //	showCancelButton: false,
                            //	confirmButtonText: "Tamam",
                            //	closeOnConfirm: true,
                            //	timer: 15000
                            //});
                            window.location = '/Error';


                        }
                    });
                }
            }


        }
    });


});
function CollectInfo() {


    var IdActivityName = $('#IdActivityName').val();
    var IdActivityType = $('#IdActivityType').val();
    var IdActivityStarTime = $('#IdActivityStarTime').val();
    var IdActivityEndTime = $('#IdActivityEndTime').val();
    var IdActivityWorkers = $('#IdActivityWorkers').val();
    var IdActivityDetails = $('#IdActivityDetails').val();


    var infoData = {
        'ActivityName': IdActivityName,
        'ActivityTypeId': IdActivityType,
        'ActivityStarTime': IdActivityStarTime,
        'ActivityEndTime': IdActivityEndTime,
        'WorkersId': IdActivityWorkers,
        'ActivityDetails': IdActivityDetails,
    };

    return infoData;
}