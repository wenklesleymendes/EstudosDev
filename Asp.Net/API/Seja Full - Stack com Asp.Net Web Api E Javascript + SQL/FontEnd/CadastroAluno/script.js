var tbody = document.querySelector('table tbody');
var aluno = {};

function Cadastrar() {

    aluno.Nome = document.querySelector('#Nome').value;
    aluno.Sobrenome = document.querySelector('#Sobrenome').value;
    aluno.Telefone = document.querySelector('#Telefone').value;
    aluno.RA = document.querySelector('#RA').value;

    console.log(aluno);

    if (aluno.Id === undefined || aluno.Id === 0) 
    {
        salvarEstudantes('POST', 0, aluno);
    }
    else
    {
        salvarEstudantes('PUT', aluno.Id, aluno);
    }

    CarregaEstudantes();  
    $('#myModal').modal('hide');          
}

function NovoAluno(){

    var btnSalvar = document.querySelector('#btnSalvar');
    var tituloModal = document.querySelector('#tituloModal');

    document.querySelector('#Nome').value = '';
    document.querySelector('#Sobrenome').value = '';
    document.querySelector('#Telefone').value = '';
    document.querySelector('#RA').value = '';

    Aluno = {};

    btnSalvar.textContent = 'Cadastrar';

    titulo.textContent = 'Cadastrar Aluno'

    $('#myModal').modal('show');

}

function Cancelar(){

    var btnSalvar = document.querySelector('#btnSalvar');
    var tituloModal = document.querySelector('#tituloModal');

    document.querySelector('#Nome').value = '';
    document.querySelector('#Sobrenome').value = '';
    document.querySelector('#Telefone').value = '';
    document.querySelector('#RA').value = '';

    Aluno = {};

    btnSalvar.textContent = 'Cadastrar';

    titulo.textContent = 'Cadastrar Aluno'

    $('#myModal').modal('hide');
}

function CarregaEstudantes() {
    tbody.innerHTML = '';

    var xhr = new XMLHttpRequest();

    xhr.open(`GET`, `https://localhost:44399/Api/aluno`, true);

    xhr.onerror = function() {
        console.log('ERRO', xhr.readyState);
    }

    xhr.onreadystatechange = function() {
        if (this.readyState == 4) {
           if ( this.status == 200) {
            var estudantes = JSON.parse(this.responseText);
            for(var indice in estudantes){
                adicionaLinha(estudantes[indice]);
            }
            else if (this.status == 500) {
                var erro = JSON.parse(this.responseText);
                console.log(erro);

            }
        }
    }

}

xhr.send();
}

function salvarEstudantes(metado, id, corpo) {

    var xhr = new XMLHttpRequest();

    if (id === undefined || id === 0) 
    {
        id = '';
    }

    xhr.open(metado, `https://localhost:44399/Api/aluno/${id}`, false);
    xhr.setRequestHeader('content-type','application/json');
    xhr.send(JSON.stringify(corpo));
}

function ExcluirEstudante(id) {

    var xhr = new XMLHttpRequest();
    xhr.open(`DELETE`, `https://localhost:44399/Api/aluno/${id}`, false);
    xhr.send();
}

function Excluir (estudante) {

    bootbox.confirm({
        message: `Tem certeza deseja excluir o estudante ${estudante.Nome} ?`,
        buttons: {
            confirm: {
                label: 'Sim',
                className: 'btn-success'
            },
            cancel: {
                label: 'Não',
                className: 'btn-danger'
            }
        },
        callback: function (result) {
            if (result) {
             ExcluirEstudante(estudante.Id);
             CarregaEstudantes();
         }
     }
 });

}

CarregaEstudantes();

function EditarEstudante(estudante){

    var btnSalvar = document.querySelector('#btnSalvar');
    var titulo = document.querySelector('#titulo');

    document.querySelector('#Nome').value = estudante.Nome;
    document.querySelector('#Sobrenome').value = estudante.Sobrenome;
    document.querySelector('#Telefone').value = estudante.Telefone;
    document.querySelector('#RA').value = estudante.RA;

    btnSalvar.textContent = 'Salvar';

    titulo.textContent = `Editar Aluno ${estudante.Nome}`;
    aluno = estudante;
    console.log(aluno);
}

function adicionaLinha(estudante) {

    var trow = `<tr>
    <td>${estudante.Nome}</td>
    <td>${estudante.Sobrenome}</td>
    <td>${estudante.Telefone}</td>
    <td>${estudante.RA}</td>
    <td><button class="btn btn-info" data-toggle="modal" data-target="#myModal" onclick='EditarEstudante(${JSON.stringify(estudante)})'>Editar</button></td>
    <td><button class="btn btn-danger" onclick='Excluir(${JSON.stringify(estudante)})'>Excluir</button></td>
    </tr>
    `
    tbody.innerHTML += trow;
}