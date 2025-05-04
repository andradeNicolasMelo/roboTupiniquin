# Projeto Robô Tupiniquim - Console App

Este é um projeto em C# que simula o movimento de um robô dentro de um grid 2D, com base em comandos fornecidos pelo usuário. O projeto é dividido em partes bem organizadas, com validação de entrada e controle de movimentação.

---

## 🧠 Objetivo

Simular a movimentação de um robô em um plano cartesiano (grid), a partir de coordenadas iniciais, direção e comandos como:

- **M** – mover uma posição para frente
- **E** – virar para a esquerda
- **D** – virar para a direita

---

## 📂 Estrutura dos Arquivos

### `Program.cs`

Arquivo principal que inicializa o programa e chama os métodos responsáveis por configurar o grid e controlar o robô.

### `DefinidorGrid.cs`

Responsável por receber e validar o tamanho do grid definido pelo usuário. Utiliza a estrutura `do...while` para garantir que:

- A entrada contenha **dois números inteiros positivos**
- Os valores estejam separados por **espaço**
- A entrada só é aceita se for válida
