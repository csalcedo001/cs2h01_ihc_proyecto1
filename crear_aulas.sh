#!/bin/bash

URL="https://fake-clases-api-m3g35jkzdq-uc.a.run.app/aulas/"
HEADER="Content-Type: application/json"

curl $URL -d '{"codigo":"L507","capacidad":12}' --header $HEADER
curl $URL -d '{"codigo":"L506","capacidad":8}' --header $HEADER
curl $URL -d '{"codigo":"L505","capacidad":24}' --header $HEADER
