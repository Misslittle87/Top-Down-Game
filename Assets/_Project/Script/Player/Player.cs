using Assets._Project.Script.Characters;
using Assets._Project.Script.Player;
using UnityEngine;


[RequireComponent(typeof(BaseMovement))]
[RequireComponent(typeof(PlayerInput))]
public class Player : MonoBehaviour
{
    public BaseMovement Movement { get; private set; }
    public PlayerInput PlayerInput { get; private set; }

    private void Awake()
    {
        Movement = GetComponent<BaseMovement>();
        PlayerInput = GetComponent<PlayerInput>();
    }
}
