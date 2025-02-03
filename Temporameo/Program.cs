using reactBackend.Models.Repository;

AlumnoDAO alumnoDAO = new AlumnoDAO();
var alumno = alumnoDAO.SelectAll();

#region Select All
foreach (var item in alumno)
{
    Console.WriteLine(item.Nombre);
}
#endregion

Console.WriteLine(" ");
#region Select By ID

var SelectByID = alumnoDAO.GetById(1000);
Console.WriteLine(SelectByID?.Nombre);

#endregion
