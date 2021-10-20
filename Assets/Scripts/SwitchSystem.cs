using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public static bool debugMode = true; //Activa o desactiva el modo debug
    public static bool debugShowIds = true; //Hace que, si el modo debug est� activado, se muestren los IDs de los objetos
    public static bool debugShowEnemyFollowInfo = true; //Hace que, si el modo debug est� activado, se muestren las trayectorias de los enemigos
    public static bool debugTurboMode = true; //Hace que, si el modo debug est� activado, el juego funcione a mayor velocidad
    public static bool debugDialogs = true; //Hace que, si el modo debug est� activado, se pueda forzar la aparici�n de los di�logos
}
