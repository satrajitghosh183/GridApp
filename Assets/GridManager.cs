using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{   
    public Sprite sprite;
    public float [,] Grid;
    int vertical,horizontal,Coulmns,Rows;

     
    // Start is called before the first frame update
    void Start()
    {
        vertical=(int)Camera.main.orthographicSize;
        horizontal=vertical*(Screen.width/Screen.height);
        Coulmns=horizontal*2;
        Rows=vertical*2;
        Grid=new float[Coulmns,Rows];
        for(int i=0; i<Coulmns;i++)
        {
            for(int j=0;j<Rows;j++)
            {
                Grid[i,j]=Random.Range(0.0f,1.0f);
                SpawnTile(i,j,Grid[i,j]);
            }
        }
    }
 private void SpawnTile(int x,int y,float value)
 {
    GameObject G=  new GameObject("x:"+x+"y"+y);
    G.transform.position=new Vector3(x-(horizontal-0.5f),y-(vertical-0.5f));
    var s=G.AddComponent<SpriteRenderer>();
    s.sprite=sprite;
    s.color=new Color(value,value,value);
 }
}
