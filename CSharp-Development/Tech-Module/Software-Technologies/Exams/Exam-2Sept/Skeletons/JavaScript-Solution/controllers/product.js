const Product = require('../models/Product');

module.exports = {
	index: (req, res) => {
        Product.find().then(products => {
            return res.render('product/index', {'entries': products});
        })
    	},
	createGet: (req, res) => {
        res.render('product/create');
	},
	createPost: (req, res) => {
        let product = req.body;

        Product.create(product).then(product => {
            res.redirect('/');
        });
	},
	editGet: (req, res) => {
        let id = req.params.id;

        Product.findById(id).then(product => {
            res.render('product/edit', product)
        })
	},
	editPost: (req, res) => {
        let id = req.params.id;
        let product = req.body;

        Product.findByIdAndUpdate(id, product).then(product => {
            res.redirect('/');
        })
    }
};