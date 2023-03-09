using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToughBalloon : Balloon
{
    public float floatrate = 2f;
    public int score = 5;

    private void Awake()
    {
        ScoreToGive = score;
        ClicksToPop = 5;
        ScaleChangePerClick = 2;
        Color = Color.blue;
        SetColor();
    }

    private void Update()
    {
        BalloonFloat();
        PopBalloon();
    }

    public override void BalloonFloat()
    {
        transform.Translate(Vector3.up * floatrate * Time.deltaTime);
    }
}
