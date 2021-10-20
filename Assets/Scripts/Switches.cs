using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public static bool debugMode = true; //Activa o desactiva el modo debug
    public static bool debugShowIds = true; //Hace que, si el modo debug está activado, se muestren los IDs de los objetos
    public static bool debugShowEnemyFollowInfo = true; //Hace que, si el modo debug está activado, se muestren las trayectorias de los enemigos
    public static bool debugTurboMode = true; //Hace que, si el modo debug está activado, el juego funcione a mayor velocidad
    public static bool debugDialogs = true; //Hace que, si el modo debug está activado, se pueda forzar la aparición de los diálogos
}
