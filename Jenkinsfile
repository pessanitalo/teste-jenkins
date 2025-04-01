pipeline {
    agent any

    stages {
        stage('Start') {
            steps {
                script{
                    dockerapp = docker.build("italopessan/api-jenkins:latest", '-f ./teste-jenkins/teste-jenkins/Dockerfile .')
                }
            }
        }
    }
}
