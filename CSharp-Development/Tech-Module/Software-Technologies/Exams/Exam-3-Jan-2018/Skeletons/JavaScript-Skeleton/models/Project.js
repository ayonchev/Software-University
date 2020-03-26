const mongoose = require('mongoose');

let projectSchema = mongoose.Schema({
    title: {type: "string", required: "true"},
    description: {type: "string", required: "true"},
    budget: {type: "number", required: "true"}
});

let Project = mongoose.model('Project', projectSchema);

module.exports = Project;