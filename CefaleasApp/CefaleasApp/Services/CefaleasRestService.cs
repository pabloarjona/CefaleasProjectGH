using Pitasoft.Client;
using Pitasoft.Result;
using System;
using System.Threading.Tasks;
using CefaleasApp.Entities;
using CefaleasApp.Services.Interfaces;

namespace CefaleasApp.Services
{
    public class CefaleasRestService : RestServiceBase, IEnfermedadRestService, ICuestionarioRestService, IPacienteRestService, IUsuarioRestService
    {
        public CefaleasRestService(SettingRestService setting) : base(setting) { }
        //POST
        public Task<ResultEntity<Enfermedad>> AddEnfermedadAsync(Enfermedad enfermedad) => PostAsync("/api/Enfermedad", enfermedad);
        //DELETE
        public Task<Result> DeleteEnfermedadAsync(int IdEnfermedad) => DeleteAsync($"/api/Enfermedad/{IdEnfermedad}");
        //GET
        public Task<ResultEntity<Enfermedad>> GetEnfermedadAsync(int IdEnfermedad) => GetAsync<Enfermedad>($"/api/Enfermedad/{IdEnfermedad}");
        //PUT
        public Task<ResultEntity<Enfermedad>> UpdateEnfermedadAsync(Enfermedad enfermedad) => PutAsync("/api/Enfermedad", enfermedad);
        public Task<ResultEntity<Cuestionario>> AddCuestionarioAsync(Cuestionario cuestionario) => PostAsync("/api/Cuestionario", cuestionario);
        //DELETE
        public Task<Result> DeleteCuestionarioAsync(int IdCuestionario) => DeleteAsync($"/api/Cuestionario/{IdCuestionario}");
        //GET
        public Task<ResultEntity<Cuestionario>> GetCuestionariosAsync(int IdPaciente) => GetAsync<Cuestionario>($"/api/Cuestionario/{IdPaciente}");
        //PUT
        public Task<ResultEntity<Cuestionario>> UpdateCuestionarioAsync(Cuestionario cuestionario) => PutAsync("/api/Cuestionario", cuestionario);
        public Task<ResultEntity<Paciente>> AddPacienteAsync(Paciente paciente) => PostAsync("/api/Paciente", paciente);
        //DELETE
        public Task<Result> DeletePacienteAsync(int IdPaciente) => DeleteAsync($"/api/Paciente/{IdPaciente}");
        //GET
        public Task<ResultEntities<Paciente>> GetPacientesAsync() => GetsAsync<Paciente>("/api/Paciente");
        //GET
        public Task<ResultEntities<Paciente>> GetPacientesAsyncId(int IdUsuario) => GetsAsync<Paciente>($"/api/Paciente/{IdUsuario}");
        //PUT
        public Task<ResultEntity<Paciente>> UpdatePacienteAsync(Paciente paciente) => PutAsync("/api/Paciente", paciente);

        //POST
        public Task<ResultEntity<Usuario>> AddUsuarioAsync(Entities.Usuario usuario) => PostAsync("/api/Usuario", usuario);
        //DELETE
        public Task<Result> DeleteUsuarioAsync(int UsuarioId) => DeleteAsync($"/api/Usuario/{UsuarioId}");
        //GET
        public Task<ResultEntities<Entities.Usuario>> GetUsuariosAsync() => GetsAsync<Entities.Usuario>("/api/Usuario");
        //GET 
        public Task<ResultEntity<Usuario>> GetUsuarioAsync(int id) => GetAsync<Usuario>($"/api/Usuario/{id}");
        //PUT
        public Task<ResultEntity<Entities.Usuario>> UpdateUsuarioAsync(Entities.Usuario usuario) => PutAsync("/api/Usuario", usuario);

    }
}
