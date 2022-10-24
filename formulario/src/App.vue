<template>
  <div>
    <table>
      <tbody>
          <tr v-for="empleado in empleados" :key="empleado.id"> 
          <td>{{ empleado.id_empleados }}</td>
          <td>{{ empleado.codigo }}</td>
          <td>{{ empleado.nombres }}</td> 
          <td>{{ empleado.apellidos }}</td>
          <td>{{ empleado.direccion }}</td>
          <td>{{ empleado.telefono }}</td> 
          <td>{{ empleado.fecha_nacimiento }}</td>
          </tr>
      </tbody>
    </table>
  </div>
</template>

<script>
import axios from 'axios'
export default{
  data(){
    return{
      empleados:null
    }
  },
  mounted(){
    this.getEmpleados();
  },
  methods:  {
    getEmpleados(){
      axios
         .get(' https://127.0.0.1:5001/api/Empleados')
            .then( Response => {
                console.log(Response)
                this.empleados = Response.data
            })
            .catch(e=> console.log(e))
    }
  }
}
</script>

<style>
</style>
