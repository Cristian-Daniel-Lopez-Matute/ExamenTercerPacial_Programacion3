using ExamenTercerPacial_Programacion3.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace ExamenTercerPacial_Programacion3.Pages.Usuarios;

partial class Usuarios
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    private IEnumerable<Usuario> usuariosLista { get; set; }

    protected override async Task OnInitializedAsync()
    {
        usuariosLista = await _usuarioServicio.GetLista();
    }


}
