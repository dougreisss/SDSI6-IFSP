document.getElementById('fileInput').addEventListener('change', function (event) {
    const file = event.target.files[0];
    if (file) {
        const reader = new FileReader();

        // Quando o arquivo é carregado, tentar validar o XML
        reader.onload = function (e) {
            const xmlString = e.target.result;
            validarXML(xmlString);
        };

        reader.readAsText(file);
    }
});

function validarXML(xmlString) {
    const parser = new DOMParser();
    const xmlDoc = parser.parseFromString(xmlString, "application/xml");
    const mensagemDiv = document.getElementById('mensagem');

    // Verifica se há algum erro no XML
    const erro = xmlDoc.getElementsByTagName("parsererror");

    if (erro.length > 0) {
        mensagemDiv.innerHTML = `<p style="color: red;">Erro encontrado no XML: ${erro[0].textContent}</p>`;
    } else {
        mensagemDiv.innerHTML = `<p style="color: green;">O XML está bem formado!</p>`;
    }
}
