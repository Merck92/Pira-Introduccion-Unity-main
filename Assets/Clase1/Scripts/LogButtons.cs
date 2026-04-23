using UnityEngine;
using UnityEngine.UI;

public class LogButtons : MonoBehaviour
{

    // TAREA 1: Haz que este botón muestre un mensaje normal en consola (color blanco)
    public void ShowLogInfoMessage()
    {
        // Escribe tu código aquí:
        Debug.Log("Todavía no está nevando.");
    }

    // TAREA 2: Haz que este botón muestre una ADVERTENCIA (triángulo amarillo)
    public void ShowLogWarningMessage()
    {
        // Escribe tu código aquí:
        Debug.Log("Esa acción va a ocacionar que los Manos nos detecten.");
    }

    // TAREA 3: Haz que este botón muestre un ERROR (octágono rojo)
    // PLUS: Investiga cómo hacer que Unity se PAUSE automáticamente al pulsar este botón.
    public void ShowLogErrorMessage()
    {
        // Escribe tu código aquí:
        Debug.Log("¡ELLOS SABEN DONDE ESTAMOS!");
        //Marcial: Intenté con EditorApplication.Exit o Apliccation.Quit() pero ninguno me salió. También probé con el time, pero no me salió.
    }
}
