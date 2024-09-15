public interface IPersonaje {
    string nombre_personaje {get;set;}
    int vida_personaje {get;set;}
    int poder_de_ataque {get;set;}
    int puntos_de_defensa {get;set;}
    void Atacar();
    void Curar();
}

public interface IElementos {
    string nombre_elemento {get;set;}
    int poder_de_ataque {get;set;}
    int poder_de_defensa {get;set;}
}
    
    