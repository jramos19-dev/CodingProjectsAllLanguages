
const express = require('express')
const router = express.Router()


router.get('/', (req, res) => {
    res.send('employee List')
})


router.get('/new', (req, res)=> {
    res.send(' New employee Form')
})


module.exports = router