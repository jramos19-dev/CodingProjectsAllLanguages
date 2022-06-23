
const express = require('express')
const res = require('express/lib/response')
const router = express.Router()


// /* the http request for the backend. Here we create
// a request for every resource that we want to expose. We want to be specific to the type
// of movement that we want to do with each resource. like get , update , delete and insert .
// */

// // make sure that dynamic routes are placed at the bottom because it can be triggered before
// // the static routes , which would cause erroreous results.


// //--------------downloads-----------------//

// // this one should get all of the clients
// router.get('/', (req, res) => {
//     res.send('client List')
// })
// // this one should only get a specific one
// router.get('/:id', (req, res) => {
//     res.send(`getting client with id ${req.params.id}`)
// })

// //---------------updates one client----------------=---//

// //this will be for updating the specific client
// router.put('/:id', (req, res) => {
//     res.send(`updating client with id ${req.params.id}`)
// })

// //---------------deletes client----------------=---//
// router.delete('/:id', (req, res)=> {
//     res.send(` Deleting client with id ${req.params.id} `)
// })
// //---------------delete all clients --------------//
// router.delete('/', (req, res) => {
//     res.send('deleting all clients')
// })


// //---------------inserting clients --------------//
// router.post('/', (req, res) => {
//     req.params.id
//     res.send('creating new user')
// })

// old way of doing it.. new way is down here with the route property


///fake data for now 
const clients = [
    { id: 0, name: 'jorge', lastname: 'ramos', email: 'jlramoss@yahoo.com', phone: 8989998989, birthday: '11/22/2299' },
    { id: 1, name: 'collin', lastname: 'BreedLove', email: 'collinB@yahoo.com', phone: 989898, birthday: '11/23/2299' },
    { id: 2, name: 'Michelle', lastname: 'Solis', email: 'collinB@yahoo.com', phone: 989898, birthday: '11/23/2299' }] 






router.route('/:id')
    .get((req, res) => {
        
        res.send(`getting client with id ${req.params.id}`)
        selectedClient = clients[req.params.id]
        res.json(req.client.name)
})
.put((req, res) => {
    res.send(`updating client with id ${req.params.id}`)
})
.delete((req, res) => {
    res.send('deleting all clients')
})

router.route('/')
.get((req, res) => {
    res.send('client List')
})
.delete((req, res)=> {
    res.send('deleting all clients')
})
    .put((req, res) => {
  res.send("Adding a new client")  
})


/// router params is the first type of middle ware that allows us to run other pieces of code during the transmission messsages to our server.
// we are basically saying everytime any of the requests that someone makes to the server has some  variable with the name id . do what is in this block of code, and then stop until i tell you 
//what to do next. 
router.param('id', (req, res, next, id) => {
    console.log('hello from within your router param function')
    req.client = clients[id]
    next()

})



module.exports = router;