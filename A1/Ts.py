#  === TCP server.py ===
from socket import *

IP = ''
PORT = 7788
BUFLEN = 512
listenSocket = socket(AF_INET, SOCK_STREAM)
listenSocket.bind((IP, PORT))

listenSocket.listen(8)
print(f'The server has started successfully, waiting for the client to connect at port {PORT}...')
dataSocket, addr = listenSocket.accept()
print('Accept a client connection:', addr)
while True:
    recved = dataSocket.recv(BUFLEN)
    if not recved:
        break
    info = recved.decode()
    print(f'Received the other party\'s information: {info}')
    dataSocket.send(f'The server received the information {info}'.encode())
dataSocket.close()
listenSocket.close()
