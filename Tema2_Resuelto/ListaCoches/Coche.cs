// =====================================================================
//  Clase Coche (Agregar > Clase en el Explorador de soluciones)
// =====================================================================
//  Cada fila de la lista será un OBJETO Coche, no un simple texto.
//  El objeto guarda más datos de los que se ven en la fila.
// =====================================================================
namespace ListaCoches;

public class Coche
{
    // { get; set; } = se puede leer y asignar.  = "" -> valor inicial
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public string Color { get; set; } = "";    // EJERCICIO 3.5-2

    // ToString() decide qué texto se ve en la fila del ListBox.
    // "override" = sustituimos el ToString que traen todos los objetos
    // (que mostraría "ListaCoches.Coche") por uno útil.
    // El color NO se muestra en la fila, pero el objeto lo guarda.
    public override string ToString()
    {
        return Marca + " " + Modelo;
    }
}
