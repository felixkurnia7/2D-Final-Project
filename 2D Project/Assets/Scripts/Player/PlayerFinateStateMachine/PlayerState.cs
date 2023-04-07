using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class PlayerState akan menjadi base class dari semua state pada player. Jadi semua state yang dibuat akan diturunkan dari PlayerState
// Semua objek state yang berbeda-beda akan dibuat di script player. Dan script player state machine akan memiliki referensi ke state yang akan dijalankan.
public class PlayerState
{
    // variabel yang mereferensi ke class Player, PlayerStateMachine, dan PlayerData
    protected Player player;
    protected PlayerStateMachine stateMachine;
    protected PlayerData playerData;

    // startTime berjalan setiap player memasuki suatu state. Ini bertujuan untuk mengetahui berapa lama player dalam state tersebut
    protected float startTime;
    
    // variabel untuk menyimpan nama animasi yang akan dijalankan oleh animator
    private string animBoolName;

    // Constructor
    public PlayerState(Player player, PlayerStateMachine stateMachine, PlayerData playerData, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.playerData = playerData;
        this.animBoolName = animBoolName;
    }

    // Setiap state memiliki fungsi enter, exit, update, dan fix update
    // update == logicupdate, fix update == physics update
    public virtual void Enter() // fungsi dipanggil saat memasuki suatu state
    {
        DoChecks();
        player.Anim.SetBool(animBoolName, true);
        startTime = Time.time;
        Debug.Log(animBoolName);
    }

    public virtual void Exit() // fungsi dipanggil saat keluar suatu state
    {
        player.Anim.SetBool(animBoolName, false);
    }

    public virtual void LogicUpdate() // fungsi dipanggil setiap frame
    {

    }

    public virtual void PhysicsUpdate() // fungsi dipanggil setiap fixupdate
    {
        DoChecks();
    }

    // fungsi dipanggil pada saat physics update dan enter. Untuk memberitahukan apakah player dalam ground atau wall, dsb.
    public virtual void DoChecks()
    {

    }
}
