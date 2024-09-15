public interface IPersonaje {
    string Nombre {get;set;}
    int Puntos_de_salud {get;set;}
    int Puntos_de_ataque {get;set;}
    int Puntos_de_defensa {get;set;}
    void Atacar();
    void Curar();
}

public interface IElementos {
    string Nombre_elemento {get;set;}
    int Poder_de_ataque {get;set;}
    int Poder_de_defensa {get;set;}
}
    
    