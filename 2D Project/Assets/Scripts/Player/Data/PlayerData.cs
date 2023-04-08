using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PlayerData adalah scriptable object dimana dalam class ini akan dideklarasikan semua variabel yang dimiliki player
// seperti movement speed, jump force, dan sebagainya
[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data")]
public class PlayerData : ScriptableObject
{
    [Header("Move State")]
    public float movementVelocity = 10f;

    [Header("Jump State")]
    public float jumpVelocity = 15f;
    public int amountOfJumps = 1;

    [Header("In Air State")]
    public float coyoteTime = 0.2f;
    public float variableJumpHeightMultiplier = 0.5f;

    [Header("Check Variables")]
    public float groundCheckRadius = 0.2f;
    public LayerMask whatIsGround;
}
