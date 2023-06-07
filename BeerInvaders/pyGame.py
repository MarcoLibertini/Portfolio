import pygame
import random
import math
from pygame import mixer


#inicializar pygame
pygame.init()

#crea la pantalla
pantalla = pygame.display.set_mode((800,600))



#titulo e icono
pygame.display.set_caption('BeerInvaders',)
icono = pygame.image.load('b.png')
pygame.display.set_icon(icono)
fondo = pygame.image.load('wall1.png')


#agregar musica
mixer.music.load('background.mp3')
mixer.music.set_volume(0.3)
mixer.music.play(-1) #para crear un loop que se ejecute cada vez que termine



#Variables del Jugador
imgJugador = pygame.image.load('navepx.png')
jugadorX = 368 #la mitad de la pantalla - la mitad de la imagen
jugadorY = 510 #cambiamos la ubicacion ya centrada a la parte inferior
jugadorXcambio = 0 #la posicion a la que cambia el jugador


#Variables enemigos
imgEnemigo = []
enemigoX = []
enemigoY = []
enemigoXcambio = []
enemigoYcambio = []
cantidadAmigos = 5

amigos = ['jupx.png','rpx.png','jppx.png','gpx.png','mpx.png']

# carga las imágenes en la lista imgEnemigo
for amigo in amigos:
    imgEnemigo.append(pygame.image.load(amigo))

#Variables amigos
for a in range(cantidadAmigos):
    # selecciona una imagen aleatoria de la lista imgEnemigo
    indice_imagen = random.randint(0, len(imgEnemigo)-1)
    enemigoX.append(random.randint(0,736))
    enemigoY.append(random.randint(50,200))
    enemigoXcambio.append(1)
    enemigoYcambio.append(50)

#Variables cerveza
imgCerveza = pygame.image.load('cerveza.png')
cervezaX = 0
cervezaY = 510
cervezaXcambio = 0
cervezaYcambio = 5
cervezaVisible = False

#alcohol en sangre
alcoholemia = 0
fuente = pygame.font.Font('Diary-Queen.ttf', 100)
textoX = 10
textoY = 10

#texto final del juego
fuenteFinal = pygame.font.Font('Diary-Queen.ttf', 200)


#funcion que muestra el texto del final
def textoFinal():
    miFuenteFinal = fuenteFinal.render('Anda a dormir.', True,(255,255,255))
    pantalla.blit(miFuenteFinal,(200,200))


#funcion que muestra la alcholemia
def mostrarAlcoholemia(x,y):
    texto = fuente.render(f'Alcoholemia: {alcoholemia}', True, (255,255,255))
    pantalla.blit(texto, (x, y))


#defino ubicacion del jugador
def jugador(x,y): #ponemos valores variables
    pantalla.blit(imgJugador, (x, y))


#defino ubicacion del jugador
def enemigo(x,y, amigo): #ponemos valores variables
    pantalla.blit(imgEnemigo[amigo], (x, y))


#Disparar cerveza
def dispararCerveza(x,y):
    global cervezaVisible
    cervezaVisible = True
    pantalla.blit(imgCerveza, (x+16,y+10))


#detectar colisiones
def hayColision(x1,y1,x2,y2):
    distancia = math.sqrt(math.pow(x1-x2,2) + math.pow(y1-y2,2)) #formula distancia
    if distancia < 27:
        return True
    else:
        return False




#loop del juego
seEjecuta = True
while seEjecuta:

    #RGB
    # elijo los colores de la pantalla
    pantalla.fill((205, 144, 228))

    #imagen de fondo
    pantalla.blit(fondo, (0,0))

    #evento cerrar
    for evento in pygame.event.get():
        if evento.type == pygame.QUIT: #si se apreta la cruz se sale
            seEjecuta = False

        #evento presionar teclas
        if evento.type == pygame.KEYDOWN: #metodo que nota la presion de una tecla
            if evento.key == pygame.K_LEFT: #aca se fija si la tecla apretada es la izq
                jugadorXcambio = -3
            if evento.key == pygame.K_RIGHT: # aca la derecha
                jugadorXcambio = 3
            if evento.key == pygame.K_SPACE: #barra espaciadora dispara
                if not cervezaVisible: #solo se hacen las cambios si la bala no se ve
                    cervezaX = jugadorX
                    dispararCerveza(cervezaX, cervezaY)
                    sonidoCerveza = mixer.Sound('shoot.mp3') #agregro el sonido del disparo
                    sonidoCerveza.play()



        #evento que avisa si se sueltan flechas
        if evento.type == pygame.KEYUP: #metodo que nos avisa si se deja de presionar una tecla
            if evento.key == pygame.K_LEFT or evento.key == pygame.K_RIGHT:
                jugadorXcambio = 0



    #el valor que modifica el movimiendo del personaje sobre eje x
    jugadorX += jugadorXcambio

    #mantener en los limites de la pantalla
    if jugadorX <= 0:
        jugadorX = 0
    elif jugadorX >= 736: #este valor sale de la resta de los 64px de la imagen con la pantalla
        jugadorX = 736

    # movimiento de los enemigos/amigos
    for a in range(cantidadAmigos):
        # fin del juego
        if enemigoY[a] > 450:
            for k in range(cantidadAmigos):
                enemigoY[k] == 1000
            textoFinal() #si el enemigo/amigo llega a la altura del jugador termina
            break

        enemigoX[a] += enemigoXcambio[a]

    # mantener en los limites de la pantalla al enemigo
        if enemigoX[a] <= 0:
            enemigoXcambio[a] = 1.5
            enemigoY[a] += enemigoYcambio[a]
        elif enemigoX[a] >= 736:  # este valor sale de la resta de los 64px de la imagen con la pantalla
            enemigoXcambio[a] = -1.5
            enemigoY[a] += enemigoYcambio[a]

            # hay colision?
        colision = hayColision(enemigoX[a], enemigoY[a], cervezaX, cervezaY)
        if colision:
            sonidoColision = mixer.Sound('hit.mp3') #sonido de colision
            sonidoColision.play()
            cervezaY = 500
            cervezaVisible = False
            alcoholemia += 1 #suma alcohlemia en cada hit
            enemigoX[a] = random.randint(0, 736)
            enemigoY[a] = random.randint(50, 200)

        enemigo(enemigoX[a], enemigoY[a], a)

    #Movimiendo de la cerveza
    #cuando la bala desaparece de pantalla se reinicia
    #y podemos volver a disparar
    if cervezaY <= -64:
        cervezaY = 500
        cervezaVisible = False


    #aca se hace visible
    if cervezaVisible:
        dispararCerveza(cervezaX,cervezaY)
        cervezaY -= cervezaYcambio



    jugador(jugadorX, jugadorY)
    mostrarAlcoholemia(textoX,textoY)

    #actualizo la pantalla
    pygame.display.update()