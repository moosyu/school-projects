var users = {
    user1: {
        name: "Steve"
    },
    user2: {
        name: "Charles"
    }
};
console.log(Object.values(users).map(function (user) { return ({
    slug: user.name.toLowerCase(),
    name: user.name,
}); }));
