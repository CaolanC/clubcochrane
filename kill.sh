#!/bin/bash

# Check if both arguments (start port and end port) are provided
if [ $# -ne 2 ]; then
  echo "Usage: $0 <start-port> <end-port>"
  exit 1
fi

# Assign arguments to variables
start_port=$1
end_port=$2

# Loop through the range of ports provided as arguments
for port in $(seq $start_port $end_port); do 
  pid=$(sudo lsof -t -i :$port)
  if [ ! -z "$pid" ]; then 
    echo "Killing process on port $port with PID $pid"
    sudo kill -9 $pid
  else 
    echo "No process found on port $port"
  fi 
done
