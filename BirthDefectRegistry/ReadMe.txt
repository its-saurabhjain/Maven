Use VS 2017 Add-> Add Docker Support
docker build -t birthdefectregistry .
docker run -it --rm -p 8080:80 --name sample birthdefectregistry
or
docker run -d -p 8080:80 --name sample birthdefectregistry

Docker commands
   docker ps
   docker ps -a
   docker images
   docker container ls
   docker inspect <<containerid>>
   docker inspect network bridge
   docker rm $(docker ps -a -q -f status=exited)
   docker rmi $(docker images -a -q) -f
   #push images to docker hub
   1. By re-tagging an existing local image
   docker tag birthdefectregistry itsaurabh/birthdefectregistry:maven
   2. By using docker build -t itsaurabh/<birthdefectregistry:maven
   3. by using docker commit <exiting-container> <hub-user>/<repo-name>[:<tag>] to commit changes.
   and then using for all above 3
   docker push itsaurabh/birthdefectregistry:maven
