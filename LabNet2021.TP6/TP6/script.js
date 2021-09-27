$(document).ready(function () {
  $("#limpiarFormulario").click(function () {
    $("form input").val("");
    $("form input[type=radio]").prop("checked", false);
  });
});

function validarNombre() {
  let nombre = $("#nombre").val();
  if (nombre == "") {
    alert("El campo nombre está vacío. Complete los datos por favor...");
  }
}

function validarApellido() {
  let apellido = $("#apellido").val();
  if (apellido == "") {
    alert("El campo apellido está vacío. Complete los datos por favor...");
  }
}
