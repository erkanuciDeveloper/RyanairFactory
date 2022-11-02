//----------SingUp------------------------//
$(document).ready(function () {
	var result = true;
	$("#bntAddEmploye").click(function () {
		result = true;
		var idEmpName = $('#idEmpName').val();
		var idEmpDepartman = $('#idEmpDepartman').val();
		var IdEmpMail = $('#IdEmpMail').val();
		var IdEmpContact = $('#IdEmpContact').val();
		var IdEmpSummary = $('#IdEmpSummary').val();
		if (idEmpName == "") {
			swal.fire({
				title: "Hesap Oluşturma",
				text: "Lütfen Adınız Giriniz",
				icon: "warning",
				confirmButtonClass: "btn-warning",
				showCancelButton: false,
				confirmButtonText: "Tamam",
				closeOnConfirm: "true",
				timer: 15500
			});
			document.getElementById("idEmpName").className = "formscon";

			result = false;
		}
		else if (idEmpDepartman == "") {
			swal.fire({
				title: "Hesap Oluşturma",
				text: "Lütfen Soyadınız Giriniz",
				icon: "warning",
				confirmButtonClass: "btn-warning",
				showCancelButton: false,
				confirmButtonText: "Tamam",
				closeOnConfirm: "true",
				timer: 15500
			});
			document.getElementById("idRegisterSurName").className = "formscon";
			result = false;
		}
		else if (IdEmpMail == "") {
			swal.fire({
				title: "Hesap Oluşturma",
				text: "Lütfen Mail Adresinizi Giriniz",
				icon: "warning",
				confirmButtonClass: "btn-warning",
				showCancelButton: false,
				confirmButtonText: "Tamam",
				closeOnConfirm: "true",
				timer: 15500
			});
			document.getElementById("idRegistermail").className = "formscon";
			result = false;
		}
		else if (IdEmpContact == "") {
			swal.fire({
				title: "Hesap Oluşturma",
				text: "Lütfen Kullanıcı Şifresinizi Giriniz",
				icon: "warning",
				confirmButtonClass: "btn-warning",
				showCancelButton: false,
				confirmButtonText: "Tamam",
				closeOnConfirm: "true",
				timer: 15500
			});
			document.getElementById("idRegisterpassword").className = "formscon";
			result = false;
		}
		else if (IdEmpSummary == "") {
			swal.fire({
				title: "Hesap Oluşturma",
				text: "Lütfen Kullanıcı Şifresinizi Giriniz",
				icon: "warning",
				confirmButtonClass: "btn-warning",
				showCancelButton: false,
				confirmButtonText: "Tamam",
				closeOnConfirm: "true",
				timer: 15500
			});
			document.getElementById("idRegisterpassword").className = "formscon";
			result = false;
		}
		else {
			if (result) {
				var collectedData = CollectInfo();
				var info = JSON.stringify(collectedData);
				$.ajax({
					type: "POST",
					url: "/UserAccount/Register",
					contentType: "application/json; charset=utf-8",
					data: info,
					dataType: "json",
					success: function (response) {
						if (!response.isSuccess) {
							swal.fire({
								title: "Hesap Oluşturma",
								text: response.message,
								icon: "error",
								confirmButtonClass: "btn-danger",
							});
						}
						else {
							swal.fire({
								title: "Hesap Oluşturma",
								text: "Hesap oluşturulmuştur..",
								icon: "success",
								confirmButtonClass: "btn-success",
							});
							window.location = '/Dashboard/TaskMonitoring';
							$('#idRegisterName').val('');
							$('#idRegisterSurName').val('');
							$('#idRegisterpassword').val('');
							$('#idRegistermail').val('');
							//$('#bd_example_modal_lg4').modal('hide');

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
	});


});



//-----------register------------------//
function CollectInfo() {


	var idEmpName = $('#idEmpName').val();
	var idEmpDepartman = $('#idEmpDepartman').val();
	var IdEmpMail = $('#IdEmpMail').val();
	var IdEmpContact = $('#IdEmpContact').val();
	var IdEmpSummary = $('#IdEmpSummary').val();


	var infoData = {
		'Name': idEmpName,
		'SurName': idEmpDepartman,
		'Password': IdEmpMail,
		'Email': IdEmpContact,
		'IdEmpSummary': IdEmpSummary,
	};

	return infoData;
}