win:
	g++.exe -fdiagnostics-color=always -I./include ./src/template2.cpp ./src/glad.c -o ./build/main.exe -Llib -lglfw3 -lopengl32 -lgdi32
	./build/main.exe

linux:
	g++ -fdiagnostics-color=always -I./include ./src/shaders_class.cpp ./src/glad.c -o ./build/main -Llib -lglfw -lGL -lXrandr -lX11 -lrt -ldl
	./build/main

temp1:
	g++.exe -fdiagnostics-color=always -I./include ./src/template1.cpp ./src/glad.c -o ./build/template1.exe -Llib -lglfw3 -lopengl32 -lgdi32
	./build/template1.exe

temp2:
	g++.exe -fdiagnostics-color=always -I./include ./src/template2.cpp ./src/glad.c -o ./build/template2.exe -Llib -lglfw3 -lopengl32 -lgdi32
	./build/template2.exe
	