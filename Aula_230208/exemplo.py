import json
class Musica:
    def __init__ (self, id, nome, album, banda):
        self.id = id
        self.nome = nome
        self.album = album
        self.banda = banda
    
    def __str__ (self):
        return f'{self.id} - {self.nome} - {self.banda} | {self.album}'

    #def musica_para_json(self):
    #    return self.__dict__

    @staticmethod
    def order_nome(musica):
        return musica.nome

class NMusica:
    musicas = []
    
    @classmethod
    def inserir (cls, musica):
        cls.musicas.append(musica)
    
    @classmethod
    def listar (cls):
        cls.musicas.sort(key = Musica.order_nome)
        return cls.musicas
        
    @classmethod
    def excluir (cls, m):
        removeu = False
        for musica in cls.musicas:
            if (m.id == musica.id):
                cls.musicas.remove(musica)
                removeu = True
        return removeu

    @classmethod
    def salvar(cls):
        with open('./musicas.json', mode="w") as arquivo:
            json.dump(cls.musicas, arquivo, default=lambda m: m.__dict__)

    @classmethod
    def abrir(cls):
        cls.musicas = []
        with open('./musicas.json', mode="r") as arquivo:
            musicas_json = json.load(arquivo)
            for m in musicas_json:
                musica = Musica(m['id'], m['nome'], m['album'], m['banda'])
                cls.musicas.append(musica)

def teste_salvar():
    m1 = Musica(1, "Transilvania", "Iron Maiden", "Iron Maiden")
    m2 = Musica(2, "Phantom of the Opera", "Iron Maiden", "Iron Maiden")
    NMusica.inserir(m1)
    NMusica.inserir(m2)
    for m in NMusica.listar():
        print(m)
    NMusica.salvar()  

def teste_abrir():
    NMusica.abrir()  
    for m in NMusica.listar():
        print(m)

if __name__ == "__main__":
    #teste_salvar()
    teste_abrir()
  

