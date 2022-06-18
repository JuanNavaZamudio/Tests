package main

import(
	"fmt"
	"juanitonava.com/greetings"
)

func main(){
	message := greetings.Hello("juan")
	fmt.Println(message)
}
