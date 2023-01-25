using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renderizador : MonoBehaviour
{
    // Start is called before the first frame update
    //UM SISTEMA SIMPLES DE RENDERIZAÇÃO POR CONTATO, OU TRIGGER.
    //EXPLICANDO: ADICIONANDO UM COLLIDER NO CUBO, E ATIVANDO O TRIGGER DELE, AUMENTANDO TAMBÉM O TAMANHO DO COLLIDER DO CUBO
    //O COLIDER SERVIRÁ COMO DETECTOR DE OJETOS,  QUALQUER OBJETO QUE ENTRAR EM SEU RAIO TERÁ SEU MESH RENDERER ATIVO, E OS DOS QUE SAIREM SERÃO DESATIVADOS. 
    //O TAMANHO FICA DE ACORDO COM SUA PREFERÊNCIA.
    //TAMBÉM PODEMOS DESATIVAR E ATIVAR O MESHRENDERE DE QUALQUER OBJETO INDEPENDENTE DA TAG. É SÓ REMOVER A CONDIÇÃO IF(COTHER.COMPARETAG) E UTILIZAR APENAS OTHER.GAMEOBJECT.GETCOMPONENT<MESHRENDERER>().ENABLED = FALSE/TRUE
    //O SCRIPT DEVERÁ SER INSERIDO NO COLISOR QUE VOCÊ ADICIONAR, RECOMENDO CRIAR UM CUBO OU ESFERA, ATIVAR O TRIGGER E ADICIONAR O SCRIPT A ESTE OBJETO.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other){
        if(other.CompareTag("cubo")){
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
        if(other.CompareTag("cilindro")){
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    public void OnTriggerExit(Collider other){
        if(other.CompareTag("cubo")){
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
        if(other.CompareTag("cilindro")){
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
