# Stories API

- [Story API](#story-api)
  - [Create story](#create-story)
    - [Create story Request](#create-story-request)
    - [Create story Response](#create-story-response)
  - [Get story](#get-story)
    - [Get story Request](#get-story-request)
    - [Get story Response](#get-story-response)
  - [Update story](#update-story)
    - [Update story Request](#update-story-request)
    - [Update story Response](#update-story-response)
  - [Delete story](#delete-story)
    - [Delete story Request](#delete-story-request)
    - [Delete story Response](#delete-story-response)

## Create Story

### Create Story Request

```js
POST /storys
```

```json
{
    "title": "Morning at starbucks",
    "description": "Order a breakfast set",
    "startDateTime": "2022-04-08T08:00:00"
}
```

### Create story Response

```js
201 Created
```

```yml
Location: {{host}}/storys/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "title": "Morning at starbucks",
    "description": "Order a breakfast set",
    "startDateTime": "2022-04-08T08:00:00"
}
```

## Get story

### Get story Request

```js
GET /storys/{{id}}
```

### Get story Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "title": "Morning at starbucks",
    "description": "Order a breakfast set",
    "startDateTime": "2022-04-08T08:00:00"
}
```

## Update story

### Update story Request

```js
PUT /storys/{{id}}
```

```json
{
    "title": "Morning at starbucks",
    "description": "Order a breakfast set",
    "startDateTime": "2022-04-08T08:00:00"
}
```

### Update story Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/storys/{{id}}
```

## Delete story

### Delete story Request

```js
DELETE /storys/{{id}}
```

### Delete story Response

```js
204 No Content
```