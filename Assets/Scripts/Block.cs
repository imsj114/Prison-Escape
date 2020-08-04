using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform east;
    public Transform west;
    public Transform north;

    public Transform south;

    public GameObject player;
    public Coordinate coordinate;

    public int block_index;
    

    void OnTriggerStay(Collider other){
        
        Vector3 mypos= player.transform.position;

        

        double[] dists= new double[4];
        dists[0]= Vector3.Distance(mypos,east.position);
        dists[1]= Vector3.Distance(mypos,west.position);
        dists[2]= Vector3.Distance(mypos,north.position);
        dists[3]= Vector3.Distance(mypos,south.position);


        int min_index = 0;
        for(int i=0;i<4;i++){
            double dist = dists[i];
            if(dist < dists[min_index]){
                min_index = i;
            }
        }
        Debug.Log(min_index);
        if(Input.GetKeyDown(KeyCode.F) && other.gameObject.tag =="Player"){
            Vector3 test;
            switch(min_index){
                case 0:
                    test= new Vector3(-1.5f,0.0f,0.0f)+ transform.position;
                    Debug.Log(transform.position);
                    Debug.Log("Coordinate"+block_index+""+coordinate.coor.Length);
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(-1.5f,0.0f,0.0f);
                        Debug.Log("Moved");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
                case 1:
                    test = new Vector3(1.5f,0.0f,0.0f)+ transform.position;
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(+1.5f,0.0f,0.0f);
                        Debug.Log("Moved");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
                case 2:
                    test = new Vector3(0.0f,0.0f,-1.5f)+ transform.position;
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(0.0f,0.0f,-1.5f);
                        Debug.Log("Moved");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
                case 3:
                    test = new Vector3(0.0f,0.0f,1.5f)+ transform.position;
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(0.0f,0.0f,+1.5f);
                        Debug.Log("Moved");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
        
            }
        }


        if(Input.GetKeyDown(KeyCode.G) && other.gameObject.tag =="Player"){
            Vector3 test;
            switch(min_index){
                case 0:
                    test= new Vector3(+1.5f,0.0f,0.0f)+ transform.position;
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(+1.5f,0.0f,0.0f);
                        Debug.Log("Pulled");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
                case 1:
                    test = new Vector3(-1.5f,0.0f,0.0f)+ transform.position;
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(-1.5f,0.0f,0.0f);
                        Debug.Log("Pulled");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
                case 2:
                    test = new Vector3(0.0f,0.0f,+1.5f)+ transform.position;
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(0.0f,0.0f,1.5f);
                        Debug.Log("Pulled");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
                case 3:
                    test = new Vector3(0.0f,0.0f,-1.5f)+ transform.position;
                    coordinate.coor[block_index]=test;
                    if(coordinate.check_grid(test) && coordinate.check_block_collision()){
                        transform.position=test;
                        player.transform.position= player.transform.position+ new Vector3(0.0f,0.0f,-1.5f);
                        Debug.Log("Pulled");
                    }
                    else{
                        coordinate.coor[block_index]=transform.position;
                        Debug.Log("cannot move, collision occured ");
                    }
                    break;
        
            }
        }

    }
}
