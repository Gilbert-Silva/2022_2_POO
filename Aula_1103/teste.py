class Filme:
    def __init__(self, nome, ano, duracao):
        self.__nome = nome
        self.ano = ano
        self.duracao = duracao
        self.__likes = 0
class Viagem:
  def __init__(self, distancia, tempo):
    self.__distancia = distancia
    self.__tempo = tempo
  def get_distancia(self):
    return self.__distancia

class Aluno:
  pass

v = Filme("Vingadores - guerra infinita", 2018, 160)
#print(v.__nome)
print(v.ano)

v1 = Viagem(350, 4)
v1.__distancia = 100
print(v1.__distancia)
print(v1.get_distancia())
print(v1._Viagem__distancia)

a = Aluno()
a.nome = "Felipe"
a._nome = "Gilbert"
a.__nome = "Silva"
print(a.nome)
print(a.nome)
print(a.nome)

b = Aluno()
b.matricula = "234598723409"

