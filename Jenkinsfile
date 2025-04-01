pipeline {
    agent any

    stages {
    stage('Start') {
        steps {
            script {
                dockerapp = docker.build("italopessan/api-jenkins:latest", '-f Projetos/teste-jenkins/teste-jenkins/teste-jenkins/Dockerfile Projetos/teste-jenkins/teste-jenkins/teste-jenkins')
            }
        }
    }
    }
}
