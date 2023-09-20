using UnityEngine;

public class Invaders : MonoBehaviour
{
    public Invader[] prefabs;
    public int rows = 5;
    public int columns = 11;

    private void Awake()
    {
        for (int row = 0; row < this.rows; row++)
        {
            Vector3 rowPosition;
            for (int col = 0; col < this.columns; col++)
            {
                Invader invader = Instantiate(this.prefabs[row], this.transform);
                //Vector3 position = rowPosition;
            }
        }
    }
}
