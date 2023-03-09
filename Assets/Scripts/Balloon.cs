using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private const int maxScale = 22;
    private int scoreToGive = 1;
    private int clicksToPop = 5;
    private float scale = 1;
    private float scaleChangePerClick = 1.0f;
    private Color color = Color.white;
    private float floatRate = 1.0f;
    private GameManager scoreManager;

    protected int ScoreToGive { get => scoreToGive; set => scoreToGive = value; }
    protected int ClicksToPop { get => clicksToPop; set => clicksToPop = value; }
    protected float Scale { get => scale; set => scale = value; }
    protected float ScaleChangePerClick { get => scaleChangePerClick; set => scaleChangePerClick = value < 0f ? value : 0f; }
    protected Color Color { get => color; set => color = value; }
    protected float FloatRate { get => floatRate; set => floatRate = value; }

 
    public virtual void OnMouseDown()
    {
        clicksToPop -= 1;

        this.transform.localScale += Vector3.one * scaleChangePerClick;

        if(clicksToPop == 0)
        {
            GameManager.Instance.IncreaseScore(scoreToGive);
            Destroy(gameObject);
        }
    }
    public void SetColor()
    {
        this.gameObject.GetComponent<Renderer>().material.color = color;
    }

    public virtual void BalloonFloat()
    {
        transform.Translate(Vector3.up * floatRate);
    }

    public void PopBalloon()
    {
        if(transform.position.y > 25)
        {
            Destroy(gameObject);
        }

        if(transform.localScale.Equals( Vector3.one * maxScale))
        {
            Destroy(gameObject);
        }
    }

}
