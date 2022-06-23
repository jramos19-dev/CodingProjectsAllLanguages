
const express = require('express')
const router = express.Router()


router.get('/', (req, res) => {
    res.render("services")
})


router.get('/new', (req, res)=> {
    res.send(' New service Form')
})


module.exports = router