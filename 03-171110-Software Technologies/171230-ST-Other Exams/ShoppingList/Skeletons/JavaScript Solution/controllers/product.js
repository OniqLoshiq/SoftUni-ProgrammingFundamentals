const Product = require('../models/Product');

module.exports = {
	index: (req, res) => {
        Product.find().then(products => {
            products.sort(function(a, b) {
                return a.priority - b.priority;
            });
        	res.render('product/index', {'entries':products});
		});
    	},
	createGet: (req, res) => {
        res.render('product/create')
	},
	createPost: (req, res) => {
		let product = req.body;
		Product.create(product).then(product => {
			res.redirect('/');
		}).catch(err => {
			product.error = 'Cannot create product.';
                res.render('product/create', product)
        });
	},
	editGet: (req, res) => {
       let productId = req.params.id;
       Product.findById(productId).then(product => {
       	if(product){
       		res.render('product/edit', product)
		} else {
       		res.redirect('/');
		}
	   }).catch(err => res.redirect('/'));
	},
	editPost: (req, res) => {
        let productId = req.params.id;
        let prodcut = req.body;

        Product.findByIdAndUpdate(productId, prodcut, {runValidators:true}).then(prodcut => {
        	res.redirect('/');
		}).catch(err => {
			prodcut.id = productId;
			prodcut.error = 'Cannot edit product.';
			res.render('product/edit', product);
		})
	}
};