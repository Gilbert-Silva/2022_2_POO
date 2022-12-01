class Jogador:
  def __init__(self, nome, altura):
    self.nome = nome
    self.altura = altura
  def __str__(self):
    return f"{self.nome} - {self.altura}"

j1 = Jogador("Felipe", 180)
j2 = Jogador("Andre", 182)
j3 = Jogador("Radmila", 170)
js = [ j1, j2, j3 ]
print(js)
for j in js: print(j)
v = [1, 2, 3]
print(v)

