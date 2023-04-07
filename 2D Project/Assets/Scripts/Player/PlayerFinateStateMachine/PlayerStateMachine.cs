using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player state machine mereferensi variabel dan fungsi pada script PlayerState untuk menginisialisasikan state sekarang dan
// untuk mengubah ke state lainnya
public class PlayerStateMachine
{
    public PlayerState CurrentState { get; private set; }

    public void Initialize(PlayerState startingState)
    {
        CurrentState = startingState;
        CurrentState.Enter();
    }

    public void ChangeState(PlayerState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }
}
