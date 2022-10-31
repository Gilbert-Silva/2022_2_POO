class Viagem:
  def __init__(self, distancia, tempo):
    self.__distancia = distancia
    self.__tempo = tempo
  def set_distancia(self, distancia):
    if distancia >= 0: self.__distancia = distancia
  def set_tempo(self, tempo):
    if tempo > 0: self.__tempo = tempo
  def get_distancia(self): 
    return self.__distancia
  def get_tempo(self):
    return self.__tempo
  def velocidade_media(self):
    return self.__distancia/self.__tempo
  def __str__(self):
    return f"Distância = {self.__distancia} km, Tempo = {self.__tempo} h"

v1 = Viagem(350, 4)
print(f"{v1.velocidade_media()} km/h")
print(v1)
v1.__distancia = -100
print(v1.__distancia)
