#!/usr/bin/env bash
# Testa o CRUD de Projetos (rode com a API já em execução: dotnet run --no-launch-profile --urls http://localhost:5038)
URL="http://localhost:5038/api/projetos"
H='Content-Type: application/json'

echo "== 1. GET (listar)";            curl -s -w "\n-> HTTP %{http_code}\n" $URL
echo "== 2. POST (cadastrar)";        curl -s -w "-> HTTP %{http_code}\n" -X POST -H "$H" -d '{"nomeDoProjeto":"Projeto D - Senai FIT","area":"Saúde","status":true}' $URL
echo "== 3. GET /4 (buscar por id)";  curl -s -w "\n-> HTTP %{http_code}\n" $URL/4
echo "== 4. PUT /4 (atualizar)";      curl -s -w "-> HTTP %{http_code}\n" -X PUT -H "$H" -d '{"nomeDoProjeto":"Projeto D - Senai Games","area":"Entretenimento","status":false}' $URL/4
echo "== 5. GET /4 (conferir)";       curl -s -w "\n-> HTTP %{http_code}\n" $URL/4
echo "== 6. DELETE /4 (deletar)";     curl -s -w "-> HTTP %{http_code}\n" -X DELETE $URL/4
echo "== 7. GET (listar final)";      curl -s -w "\n-> HTTP %{http_code}\n" $URL
