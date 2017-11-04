using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float Point
    {
        get { return p; }
    }
    private float p = 0;

    public int Conbo
    {
        get { return conbo; }
    }
    private int conbo = 0;

    [SerializeField]
    private float interval;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text conboText;

    private float timer = 0.0f;


    void Update()
    {
        timer += Time.deltaTime;

        scoreText.text = "Score : " + p.ToString("F2");
        conboText.text = "Conbo : " + conbo.ToString();
    }

    public void Add(float point)
    {
        if(timer < interval)
        {
            p += ((conbo > 10) ? point * 2 : point); 
            conbo++;
        }
        else
        {
            p += point;
            conbo = 0;
        }
        timer = 0.0f;
    }
}
