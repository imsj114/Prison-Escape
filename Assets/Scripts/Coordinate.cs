using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinate : MonoBehaviour
{
    public Vector3 start_coor=new Vector3(-9,0, 16);
    public int start_x=-9;
    public int start_z=16;



    public GameObject block1, block2,block3, block4,block5, block6, block7, block8, block9, block10, block11, block12;
    public int x_bound_upper = 22;
    public int x_bound_lower = -1;


    public int z_bound_upper=0;
    public int z_bound_lower=-11;
    public Vector3 [] coor;
    
    // Start is called before the first frame update
    void Start()
    {
        coor=new Vector3[12];
        coor[0]= (block1.transform.position);
        coor[1]= (block2.transform.position);
        coor[2]= (block3.transform.position);
        coor[3]= (block4.transform.position);
        coor[4]= (block5.transform.position);
        coor[5]= (block6.transform.position);
        coor[6]= (block7.transform.position);
        coor[7]= (block8.transform.position);
        coor[8]= (block9.transform.position);
        coor[9]= (block10.transform.position);
        coor[10]= (block11.transform.position);
        coor[11]= (block12.transform.position);


    }
    
    public bool check_grid(Vector3 position){
            if(position.x-start_x >= x_bound_lower && position.x-start_x <=x_bound_upper && position.z-start_z >= z_bound_lower && position.z-start_z<= z_bound_upper){
                Debug.Log("check_grid successfully done");
            
                return true;
            }
            else{
                return false;
            }
    }
    

    public bool check_block_collision(){
        for(int i=0; i<coor.Length; i++){
            for(int j=0; j<i; j++){
                if ((Mathf.Abs(coor[i].x- coor[j].x )<=1.5f && Mathf.Abs(coor[i].z- coor[j].z)<=1.5f)){
                    return false;
                }
            }
        }
        Debug.Log("check_block_collision successfully done");
        return true;
    }

    public Vector3 relative_coor(Vector3 position){
            return position-start_coor;
    }
}
    