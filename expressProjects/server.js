const express = require('express')

const app = express()

app.set('view engine', 'ejs')
//default engine th at we install using npm i ejg



app.listen(3000)


app.use(express.static('public'))


 const clientRouter = require('./routes/clients')
// const employeeRouter = require('./routes/employees')
const servicesRouter = require('./routes/services')
// const contractsRouter = require('/routes/contracts')


app.use('/clients', clientRouter)
// app.use('/employees', employeeRouter)
app.use('/services', servicesRouter)
// app.use('/contracts',contractsRouter)





