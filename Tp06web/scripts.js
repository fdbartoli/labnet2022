const fechaNacimiento = document.getElementById("fechanacimiento");
const edad = document.getElementById("edad");
const enviar = document.getElementById("enviar");
const nombre = document.getElementById("nombre");
const apellido = document.getElementById("apellido");
const email = document.getElementById("email");
const error = document.getElementById("error");
const limpiar = document.getElementById("limpiar");
var form = document.getElementById("formulario");

const calcularEdad = (fechaNacimiento) => {
  const fechaActual = new Date();
  const anioActual = parseInt(fechaActual.getFullYear());
  const mesActual = parseInt(fechaActual.getMonth()) + 1;
  const diaActual = parseInt(fechaActual.getDate());

  const anioNacimiento = parseInt(String(fechaNacimiento).substring(0, 4));
  const mesNacimiento = parseInt(String(fechaNacimiento).substring(5, 7));
  const diaNacimiento = parseInt(String(fechaNacimiento).substring(8, 10));

  let edad = anioActual - anioNacimiento;

  if (mesActual < mesNacimiento) {
    edad--;
  } else if (mesActual === mesNacimiento) {
    if (diaActual < diaNacimiento) {
      edad--;
    }
  }

  return edad;
};
window.addEventListener("load", function () {
  fechaNacimiento.addEventListener("change", function () {
    if (this.value) {
      edad.innerText = `Tu edad es: ${calcularEdad(this.value)} años`;
    }
  });

  form.addEventListener("submit", function (event) {
    event.preventDefault();
    var msgError = [];
    band = true;

    if (nombre.value === null || nombre.value === "") {
      msgError.push("*Ingresá tu nombre");
      band = false;
    }
    if (apellido.value === null || apellido.value === "") {
      msgError.push("*Ingresa tu apellido");
      band = false;
    }

    if (email.value === null || email.value === "") {
      msgError.push("*ingresa tu email");
      band = false;
    }

    if (fechaNacimiento.value === null || fechaNacimiento.value === "") {
      msgError.push("*Ingresar fecha de nacimiento");
      band = false;
    }

    error.innerHTML = msgError.join(", ");
    if (band) {
      alert("Enviando información!");
    }
  });

  limpiar.addEventListener("click", fun);

  function fun() {
    form.reset();
  }
});
